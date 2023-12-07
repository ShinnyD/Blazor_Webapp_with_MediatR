using System;
using DemoLib.Models;
using MediatR;

namespace DemoLib.Commands
{
	public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>
	{
		
		//public string FirstName { get; set; }
		//public string LastName { get; set; }

		//public InsertPersonCommand (string firstName, string lastName)
		//{
		//	FirstName = firstName;
		//	LastName = lastName;
		//}
	}

	
}

