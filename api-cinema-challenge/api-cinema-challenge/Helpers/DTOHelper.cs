using System.Net.Mail;
using System.Text;

namespace api_cinema_challenge.Helpers
{
    public static class DTOHelper
    {
        public static T MapToDTO<T>(object entity) where T : class
        {
            var dto = Activator.CreateInstance<T>();
            var entityProperties = entity.GetType().GetProperties();
            var dtoProperties = dto.GetType().GetProperties();

            foreach (var entityProperty in entityProperties)
            {
                foreach (var dtoProperty in dtoProperties)
                {
                    if(entityProperty.Name == "Screenings")
                    {
                        //Do nothing
                    }
                    if (entityProperty.Name == dtoProperty.Name)
                    {
                        dtoProperty.SetValue(dto, entityProperty.GetValue(entity));
                    }
                }
            }

            return dto;
        }

        public static T MapToEntity<T>(object dto, string operation) where T : class
        {
            var entity = Activator.CreateInstance<T>();
            var dtoProperties = dto.GetType().GetProperties();
            var entityProperties = entity.GetType().GetProperties();

            foreach (var dtoProperty in dtoProperties)
            {
                foreach (var entityProperty in entityProperties)
                {
                    if (dtoProperty.Name == entityProperty.Name)
                    {
                        entityProperty.SetValue(entity, dtoProperty.GetValue(dto));
                    }
                }
            }

            if (operation == "create")
            {
                var createdAtProperty = entity.GetType().GetProperty("CreatedAt");
                var updatedAtProperty = entity.GetType().GetProperty("UpdatedAt");
                if (createdAtProperty != null)
                {
                    createdAtProperty.SetValue(entity, DateTime.UtcNow);
                }
                if (updatedAtProperty != null)
                {
                    updatedAtProperty.SetValue(entity, DateTime.UtcNow);
                }
            }

            return entity;
        }


        //In retrospect this is overkill with the return inside the status of the payload... but I am too lazy to change it now.
        public static string PropertyChecker<T>(object dto) where T : class
        {
            //Create a string to return
            string returnString = "success";
            //Create a stringbuilder to append errors to
            StringBuilder sb = new StringBuilder();

            //Loop through the properties of the DTO
            foreach (var property in dto.GetType().GetProperties())
            {
                var value = property.GetValue(dto);
                var propName = property.Name;
                //General validation
                if (propName != "Id" &&
                    (value == null ||
                    value.ToString() == "" ||
                    value.ToString() == "0" ||
                    value.ToString() == "string" ||
                    value.ToString() == "name" ||
                    value.ToString() == "phone")
                    )
                {
                    sb.Append($"-Invalid property {propName}: {value.ToString()}. You have to write something in the field. {Environment.NewLine} ");
                }

                //Name validation. Should have fore- and surname. Not working as intended. It never fires :(
                /*
                if (propName == "name" && !value.ToString().Contains(" "))
                {
                    sb.Append($"-Invalid property {propName}: {value.ToString()}. You need at least a forename and surname. {Environment.NewLine} ");
                }
                */

                //Email validation.
                if (propName == "email")
                {
                    try
                    {
                        var emailAddress = new MailAddress(value.ToString());
                    }
                    catch
                    {
                        sb.Append($"-Invalid property {propName}: {value.ToString()}. Email is not correctly formated. {Environment.NewLine} ");
                    }
                }
                //Phone number validation. Should contain at least one digit. Phone is a can of worms with the possibility of +47 with the plus sign. This is just a super simple validation.
                if(propName == "phone" && !value.ToString().Any(char.IsDigit) )
                {
                    sb.Append($"-Invalid property {propName}: {value.ToString()}. Phone needs to have integers. {Environment.NewLine} ");
                }

                // Date validation. Not working as intended
                /*
                if (property.PropertyType == typeof(DateTime))
                {
                    if (!(value is DateTime) || (DateTime)value == DateTime.MinValue || (DateTime)value == DateTime.MaxValue)
                    {
                        sb.Append($"-Invalid property {propName}: {value.ToString()}. The date is not correct. {Environment.NewLine} ");
                    }
                }
                */
            }

            //If there are any errors, return the error string
            if (sb.Length > 0)
            {
                returnString = sb.ToString();
            }

            return returnString;
        }


    }
}
