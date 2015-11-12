using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using Breeze.WebApi2;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BzDemo1.Models;

namespace BzDemo1.Controllers
{
  [BreezeController]
  public class BzDemoController : ApiController
  {
    private readonly EFContextProvider<BzDemoContext> _contextProvider = new EFContextProvider<BzDemoContext>();

    [HttpGet]
    public string Metadata()
    {
      return _contextProvider.Metadata();
    }
   
    [HttpGet]
    public IQueryable<Customer> Customers()
    {
      return _contextProvider.Context.Customers;
    }
    [HttpGet]
    public IQueryable<Detail> Details()
    {
      return _contextProvider.Context.Details;
    }
    [HttpGet]
    public IQueryable<Item> Items()
    {
      return _contextProvider.Context.Items;
    }
    [HttpGet]
    public IQueryable<Order> Orders()
    {
      return _contextProvider.Context.Orders;
    }

    //[Authorize]
    [HttpPost]
    public SaveResult SaveChanges(JObject saveBundle)
    {
      return _contextProvider.SaveChanges(saveBundle);
    }

    [HttpGet]
    public object Lookups()
    {
      var customers = _contextProvider.Context.Customers;
      var details = _contextProvider.Context.Details;
      var items = _contextProvider.Context.Items;
      var orders = _contextProvider.Context.Orders;
      return new { customers, details, items, orders};
    }
  }
}
