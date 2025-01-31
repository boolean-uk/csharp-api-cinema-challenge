using System;
using api_cinema_challenge.DTO.Calls;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO;

/*
Create a new movie. Optionally, a screenings array can be provided to create screenings when the movie gets created. If no screenings array is provided, the movie should be created as normal.
Request Body schema: application/json
title
required
	
string
rating
required
	
string
description
required
	
string
runtimeMins
required
	
integer
Array of objects

{

    "title": "Dodgeball",
    "rating": "PG-13",
    "description": "The greatest movie ever made.",
    "runtimeMins": 126,
    "screenings": 

[

        {}
    ]

}
*/
public class MoviePost
{
    public string Title { get; set; }
    public string Rating { get; set; }
    public string Description { get; set; }
    public int RuntimeMins { get; set; }
    public IEnumerable<ScreeningPost> Screenings { get; set; }
}

