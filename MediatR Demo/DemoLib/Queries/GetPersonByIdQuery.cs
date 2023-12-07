using System;
using DemoLib.Models;
using MediatR;

namespace DemoLib.Queries
{
	public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;

	//public class GetPersonByIdQueryClass : IRequest<PersonModel>
	//{
	//	public int Id { get; set; }

	//	public GetPersonByIdQueryClass(int Id)
	//	{
	//		Id = id;
	//	}
	//}

}

