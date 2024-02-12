using Swashbuckle.AspNetCore.SwaggerGen;
using System.Globalization;
using System.Net.Mail;
using System.Text;

namespace api_cinema_challenge.Helpers
{
    public static class DTOHelper
    {
        public static T MapToDTO<T>(object entity, bool ignoreObjects=false, string objectToIgnore= "") where T : class, new()
        {
            var dto = new T();
            //var dto = Activator.CreateInstance<T>();

            foreach (var dtoProperty in typeof(T).GetProperties())
            {
                var entityProperty = entity.GetType().GetProperty(dtoProperty.Name);
                // This is a bit of a hack to avoid the circular reference between Movie and Screening
                if(ignoreObjects && entityProperty?.Name == objectToIgnore)
                { 
                    continue;
                }
                if (entityProperty != null && dtoProperty.CanWrite)
                {
                    dtoProperty.SetValue(dto, entityProperty.GetValue(entity));
                }
            }

            return dto;
        }

        public static T MapToEntity<T>(object dto, string operation, bool ignoreObjects = false, string objectToIgnore = "") where T : class
        {
            var entity = Activator.CreateInstance<T>();

            foreach (var dtoProperty in dto.GetType().GetProperties())
            {
                var entityProperty = entity.GetType().GetProperty(dtoProperty.Name);
                if (entityProperty != null && dtoProperty.CanRead)
                {
                    // This is a bit of a hack to avoid the circular reference between Movie and Screening
                    if (ignoreObjects && entityProperty.Name == objectToIgnore)
                    {
                        continue;
                    }
                    if (entityProperty.PropertyType == typeof(DateTime))
                    {
                        // Ensure DateTime values are converted to UTC
                        var dtoValue = (DateTime)dtoProperty.GetValue(dto);
                        var utcValue = DateTime.SpecifyKind(dtoValue, DateTimeKind.Utc);
                        entityProperty.SetValue(entity, utcValue);
                    }
                    else
                    {
                        entityProperty.SetValue(entity, dtoProperty.GetValue(dto));
                    }
                }
            }

            if (operation == "create")
            {
                var createdAtProperty = entity.GetType().GetProperty("CreatedAt");
                var updatedAtProperty = entity.GetType().GetProperty("UpdatedAt");
                createdAtProperty?.SetValue(entity, DateTime.UtcNow);
                updatedAtProperty?.SetValue(entity, DateTime.UtcNow);
            }

            return entity;
        }



        //In retrospect this is overkill with the return inside the status of the payload... but I am too lazy to change it now.
        public static string PropertyChecker<T>(object dto) where T : class
        {
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
                if (propName == "phone" && !value.ToString().Any(char.IsDigit))
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


                //Convert the dates. The spec sheet has a different format than the default format and this is needed to c
                //Excluding propName == "CreatedAt" || propName == "UpdatedAt" is the easiest way to handle some trouble I got into...
                if (propName == "StartsAt")
                {
                    if (value != null)
                    {
                        if (value.GetType() == typeof(DateTime))
                        {
                            // Convert startsAt to the desired format
                            var startsAtDateTime = (DateTime)value;
                            var formattedStartsAt = startsAtDateTime.ToString("yyyy-MM-dd HH:mm:ss.fffffffzzz");
                            property.SetValue(dto, DateTime.ParseExact(formattedStartsAt, "yyyy-MM-dd HH:mm:ss.fffffffzzz", CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            return "-Date formatting is wrong";
                        }
                    }
                }
            }

            //If there are any errors, return the error string
            if (sb.Length > 0)
            {
                return sb.ToString();
            }

            return "success";
        }
    }
}
