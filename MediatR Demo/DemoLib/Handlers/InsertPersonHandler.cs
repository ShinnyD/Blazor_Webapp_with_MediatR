using System;
using DemoLib.Commands;
using DemoLib.DataAccess;
using DemoLib.Models;
using MediatR;

namespace DemoLib.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IDataAccess _data;

        public InsertPersonHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName));
        }
    }
}

