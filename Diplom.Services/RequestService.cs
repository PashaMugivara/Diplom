using Diplom.DataAccess;
using Diplom.DataAccess.Entities;
using Diplom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOIT.Services
{
    public class RequestService : IRequestService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public RequestService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public RequestDto Create(string ticketName, string ticketDescription, Guid ticketStateId, Guid ticketTypeId, DateTime ticketDate)
        {
            try
            {
                var ticket = new Request();
                ticket.Id = Guid.NewGuid();
                ticket.Name = ticketName;
                ticket.Description = ticketDescription;
                ticket.StateId = GetState(ticketStateId).Id;
                ticket.TypeId = GetType(ticketTypeId).Id;
                ticket.Date = ticketDate;
                applicationDbContext.Tickets.Add(ticket);
                applicationDbContext.SaveChanges();
                return Converter(ticket);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Delete(Guid id)
        {
            try
            {
                var ticket = applicationDbContext.Tickets.FirstOrDefault(p => p.Id == id);
                if (ticket == null) throw new Exception("This ticket not found");
                applicationDbContext.Tickets.Remove(ticket);
                applicationDbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private StateTicketDto GetState(Guid id)
        {
            try
            {
                var state = applicationDbContext.States.FirstOrDefault(p => p.Id == id);//try-case
                if (state == null) throw new Exception("State with this guid does not exist");
                return new StateTicketDto() { Id = state.Id, Name = state.Name };
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        


        private TicketTypeDto GetType(Guid id)
        {
            try
            {
                var type = applicationDbContext.Types.FirstOrDefault(p => p.Id == id);
                if (type == null) throw new Exception("Type with this guid does not exist");
                return new TicketTypeDto() { Id = type.Id, Name = type.Name };
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }


        public TicketDto Get(Guid id)
        {
            try
            {
                var ticket = applicationDbContext.Tickets.FirstOrDefault(p => p.Id == id);
                if (ticket == null) throw new Exception("This ticket not found");
                return Converter(ticket);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
          
        }

        public IEnumerable<TicketDto> GetAll() {
            try
            {
                var tickets = applicationDbContext.Tickets;
                var dtos = new List<TicketDto>();
                foreach (Ticket ticket in tickets)
                {
                    dtos.Add(Converter(ticket));
                }
                IEnumerable<TicketDto> dto = dtos;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }
        
       

        public TicketDto Update(Guid Id, string newName, string newDescription, Guid newStateId, Guid newTypeId, DateTime newDate)
        {

            try
            {
                var ticket = applicationDbContext.Tickets.FirstOrDefault(p => p.Id == Id);

                if (newName != null)
                    ticket.Name = newName;
                if (newDescription != null)
                    ticket.Description = newDescription;
                if (newStateId != Guid.Empty)
                    ticket.StateId = GetState(newStateId).Id;
                if (newStateId != Guid.Empty)
                    ticket.TypeId = GetType(newTypeId).Id;
                    ticket.Date = newDate;

                applicationDbContext.SaveChanges();

                return Converter(ticket);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

           
        }

        private TicketDto Converter(Ticket ticket)
        {
            try
            {
                var dto = new TicketDto();
                dto.Id = ticket.Id;
                dto.Name = ticket.Name;
                dto.Description = ticket.Description;
                dto.State = GetState(ticket.StateId);
                dto.Type = GetType(ticket.TypeId);
                dto.Date = ticket.Date;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<StateTicketDto> GetAllStates()
        {
            try
            {
                var states = applicationDbContext.States;
                var dtos = new List<StateTicketDto>();
                foreach (TicketState state in states)
                {
                    dtos.Add(new StateTicketDto() { Id = state.Id, Name = state.Name });
                }
                IEnumerable<StateTicketDto> dto = dtos;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<TicketTypeDto> GetAllTypes()
        {
            try
            {
                var types = applicationDbContext.Types;
                var dtos = new List<TicketTypeDto>();
                foreach (TicketType type in types)
                {
                    dtos.Add(new TicketTypeDto() { Id = type.Id, Name = type.Name });
                }
                IEnumerable<TicketTypeDto> dto = dtos;
                return dto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
