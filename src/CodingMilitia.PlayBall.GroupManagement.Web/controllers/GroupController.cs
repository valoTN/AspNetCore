﻿using System;
using Microsoft.AspNetCore.Mvc;
using CodingMilitia.PlayBall.GroupManagement.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace CodingMilitia.PlayBall.GroupManagement.Web.controllers
{
    [Route("group")]
    public class GroupController : Controller
    {
        private static long currentGroupId = 1;
        private static List<GroupViewModel> groups = new List<GroupViewModel> { new GroupViewModel { Id = 1, Name = "Sample Group" } };


        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(groups);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Details(long id)
        {
            var group = groups.FirstOrDefault(x => x.Id == id);

            if (group == null)
                return NotFound();

            return View(group);
        }

        [HttpPost]
        [Route("{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(long id, GroupViewModel model)
        {
            var group = groups.FirstOrDefault(x => x.Id == id);

            if (group == null)
                return NotFound();

            group.Name = model.Name;

            return Redirect("/group");
        }


        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
    }
}
