using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace Web.Controllers
{
    public class TicketController : ApiController
    {


        [HttpGet]
        [Route("api/tickets")]
        public HttpResponseMessage Tickets()
        {
            try
            {
                var data = UserService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/ticket/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, TicketService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [AllowAnonymous]
        [Route("api/ticket/create")]
        [HttpPost]
        public HttpResponseMessage Create(TicketDTO ticket)
        {

            try
            {
                var data = TicketService.Create(ticket);


                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "  Successfull");
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/ticket/update")]
        public HttpResponseMessage UpdateTicket(TicketDTO ticket)
        {

            try
            {
                var data = TicketService.Update(ticket);
                return Request.CreateResponse(HttpStatusCode.OK, " Updated");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }



        [Route("api/ticket/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteTicket(string id)
        {
            var data = UserService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        
        }

    }

