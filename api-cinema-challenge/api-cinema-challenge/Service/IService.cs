namespace api_cinema_challenge.Service
{
    public interface IService
    {
        Task<IEnumerable<TDto>> MultipleToDto<TEntity, TDto>(IEnumerable<TEntity> data) where TDto : class;
        Task<TDto> SingleToDto<TEntity, TDto>(TEntity data) where TDto : class;

    }
}
