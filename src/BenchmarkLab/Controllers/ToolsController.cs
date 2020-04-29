﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Whois;

namespace BenchmarkLab.Controllers
{
    public class ToolsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult JSONBeautify()
        {
            return View();
        }

        public IActionResult JSONMinify()
        {
            return View();
        }

        public IActionResult JavaScriptBeautify()
        {
            return View();
        }

        public IActionResult HTMLBeautify()
        {
            return View();
        }

        public IActionResult CSSBeautify()
        {
            return View();
        }
        
        public IActionResult FormatSQL()
        {
            return View();
        }

        public IActionResult SortLines()
        {
            return View();
        }

        public IActionResult ComputeFileHash()
        {
            return View();
        }

        public IActionResult ConvertUnixTimestamp()
        {
            return View();
        }

        public async Task<IActionResult> WhoisLookup(string domain)
        {
            ViewData["domain"] = domain;
            if (string.IsNullOrEmpty(domain))
            {
                return View();
            }

            try
            {
                var whois = new WhoisLookup();
                var response = await whois.LookupAsync(domain);
                return View(response);
            } catch (Exception e)
            {
                ViewData["error"] = e.Message;
                return View();
            }
        }

        public IActionResult URLEncode()
        {
            return View();
        }

        public IActionResult URLDecode()
        {
            return View();
        }

        public IActionResult Base64Encode()
        {
            return View();
        }

        // User Agent String
        // Remote IP
        // Browser features
        // Base64 Encode/Decode
    }
}