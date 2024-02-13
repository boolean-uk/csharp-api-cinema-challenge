namespace api_cinema_challenge.Service
{
    public class Service : IService
    {
        public async Task<IEnumerable<TDto>> MultipleToDto<TEntity, TDto>(IEnumerable<TEntity> data) where TDto : class
        {
            return await Task.Run(() =>
            {
                var output = new List<TDto>();
                foreach (var entity in data)
                {
                    output.Add((TDto)Activator.CreateInstance(typeof(TDto), entity));
                }
                return output;
            });
        }

        public async Task<TDto> SingleToDto<TEntity, TDto>(TEntity data) where TDto : class
        {
            return await Task.Run(() =>
            {
                return (TDto)Activator.CreateInstance(typeof(TDto), data);
            });
        }
    }
}
