﻿using api_cinema_challenge.Application.Models;
using api_cinema_challenge.Infrastructure;
using api_cinema_challenge.Presentation.DTOs.Movies;
using AutoMapper;

namespace api_cinema_challenge.Presentation.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("/movies");

            group.MapGet("/{id}", Get);
            group.MapGet("/", GetAll);
            group.MapPost("/", Add);
            group.MapDelete("/{id}", Delete);
            group.MapPut("/{id}", Put);
        }

        public static async Task<IResult> Get(IRepository<Movie> repository, int id, IMapper mapper)
        {
            ServiceResponse<GetMovieDTO> response = new();
            try
            {
                Movie movie = await repository.GetById(id);
                response.Data = mapper.Map<GetMovieDTO>(movie);
                return TypedResults.Ok(movie);
            } catch (ArgumentException ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return TypedResults.NotFound(response);
            }
        }

        public static async Task<IResult> GetAll(IRepository<Movie> repository, IMapper mapper)
        {
            ServiceResponse<List<GetMovieDTO>> response = new();
            try
            {
                List<Movie> movies = await repository.GetAll();
                response.Data = movies.Select(mapper.Map<GetMovieDTO>).ToList()!;
                return TypedResults.Ok(response);
            } catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return TypedResults.BadRequest(response);
            }
        }

        public static async Task<IResult> Add(IRepository<Movie> repository, AddMovieDTO movieDTO, IMapper mapper)
        {
            ServiceResponse<GetMovieDTO> response = new();
            try
            {
                Movie movie = new()
                {
                    Title = movieDTO.Title,
                    Description = movieDTO.Description,
                    Rating = movieDTO.Ratings,
                    RuntimeMins = movieDTO.RuntimeMins
                };
                movie = await repository.Add(movie);
                response.Data = mapper.Map<GetMovieDTO>(movie);
                return TypedResults.Created(nameof(Add), response);
            } catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return TypedResults.BadRequest(response);
            }
        }

        public static async Task<IResult> Delete(IRepository<Movie> repository, int id, IMapper mapper)
        {
            ServiceResponse<GetMovieDTO> response = new();
            try
            {
                Movie movie = await repository.DeleteById(id);
                response.Data = mapper.Map<GetMovieDTO>(movie);
                return TypedResults.Ok(response);
            } catch (ArgumentException ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return TypedResults.NotFound(response);
            }
        }

        public static async Task<IResult> Put(IRepository<Movie> repository, AddMovieDTO movieDTO, int id, IMapper mapper)
        {
            ServiceResponse<GetMovieDTO> response = new();
            try
            {
                Movie movie = new()
                {
                    Title = movieDTO.Title,
                    Description = movieDTO.Description,
                    Rating = movieDTO.Ratings,
                    RuntimeMins = movieDTO.RuntimeMins
                };
                movie = await repository.UpdateById(movie, id);
                response.Data = mapper.Map<GetMovieDTO>(movie);
                return TypedResults.Ok(response);
            } catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return TypedResults.BadRequest(response);
            }
        }
    }
}