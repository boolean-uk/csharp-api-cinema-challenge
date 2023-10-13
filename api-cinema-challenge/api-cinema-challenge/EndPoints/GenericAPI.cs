using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.EndPoints
{
    public static class GenericAPI
    {
        public static void ConfigureGenericAPI<T>(this WebApplication app) where T : class
        {
            app.MapGet($"/{typeof(T).Name}/All", async (IDataRepository<T> repo) => await GetAll(repo));
            app.MapGet($"/{typeof(T).Name}/{{id:int}}", async (IDataRepository<T> repo, int id) => await GetById(repo, id));
            app.MapPost($"/{typeof(T).Name}", async (IDataRepository<T> repo, T entity) => await Add(repo, entity));
            app.MapPut($"/{typeof(T).Name}/{{id:int}}", async (IDataRepository<T> repo, T entity) => await Update(repo, entity));
            app.MapDelete($"/{typeof(T).Name}/{{id:int}}", async (IDataRepository<T> repo, int id) => await Delete(repo, id));
        }

        private static async Task<IResult> GetAll<T>(IDataRepository<T> repo) where T : class
        {
            return Results.Ok(await repo.GetAll());
        }

        private static async Task<IResult> GetById<T>(IDataRepository<T> repo, int id) where T : class
        {
            var entity = await repo.GetById(id);
            if (entity == null) return Results.NotFound();
            return Results.Ok(entity);
        }

        private static async Task<IResult> Add<T>(IDataRepository<T> repo, T entity) where T : class
        {
            await repo.Add(entity);
            return Results.Ok();
        }

        private static async Task<IResult> Update<T>(IDataRepository<T> repo, T entity) where T : class
        {
            await repo.Update(entity);
            return Results.Ok();
        }

        private static async Task<IResult> Delete<T>(IDataRepository<T> repo, int id) where T : class
        {
            await repo.Delete(id);
            return Results.Ok();
        }
    }
}