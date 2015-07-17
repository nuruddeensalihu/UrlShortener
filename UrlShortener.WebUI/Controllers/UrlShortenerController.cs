﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrlShortener.Domain.Abstract;

namespace UrlShortener.WebUI.Controllers
{
    public class UrlShortenerController : Controller
    {
        //
        // GET: /UrlShortener/
        private IUrlsRepository repository;

        public UrlShortenerController(IUrlsRepository repo)
        {
            repository = repo;
        }
        public ActionResult Index()
        {
            return View(repository.Urls);
        }

    }
}