﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Damselfly.Core.DbModels;
using Damselfly.Core.Models;

namespace Damselfly.Core.ScopedServices.Interfaces;

public interface IPeopleService
{
    Task<List<Person>> GetAllPeople();
    Task<List<string>> GetPeopleNames(string searchText);
    Task UpdatePerson(Person thePerson, string newName);
    Task UpdateName(ImageObject theObject, string newName);
}

