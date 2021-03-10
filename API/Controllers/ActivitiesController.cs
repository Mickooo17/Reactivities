using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext context;

        public ActivitiesController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public List<Activity> GetActivities()
        {
            return context.Activities.ToList();
        }
        [HttpGet("{id}")]
        public Activity GetActivity(Guid id)
        {
            return context.Activities.Find(id);
        }
    }
}


