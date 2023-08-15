using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TicketService
    {
        public static TicketDTO Create(TicketDTO ticket)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<TicketDTO, Ticket>();
                c.CreateMap<Ticket, TicketDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Ticket>(ticket);
            var data = DataAccessFactory.TicketData().Create(ht);

            if (data != null)
                return mapper.Map<TicketDTO>(data);
            return null;
        }

        public static TicketDTO Get(string id)
        {
            var data = DataAccessFactory.TicketData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Ticket, TicketDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TicketDTO>(data);
            return mapped;
        }

        public static List<TicketDTO> Get()
        {
            var data = DataAccessFactory.TicketData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Ticket, TicketDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<TicketDTO>>(data);
            return mapped;
        }

        public static TicketDTO Update(TicketDTO ticketDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<TicketDTO, Ticket>();
                c.CreateMap<Ticket, TicketDTO>();
            });
            var mapper = new Mapper(cfg);
            var ticket = mapper.Map<Ticket>(ticketDTO);
            var data = DataAccessFactory.TicketData().Update(ticket);
            if (data != null)
            {
                return mapper.Map<TicketDTO>(data);
            }
            return null;
        }

        public static bool Delete(string id)
        {

            var result = DataAccessFactory.TicketData().Delete(id);
            return result;

        }


    }
}