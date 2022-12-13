using ChatAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace ChatAPI.Controllers
{
    public class ChatroomsController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/Chatrooms
        public IQueryable<Chatroom> GetChatroom()
        {
            return db.Chatroom;
        }

        // GET: api/Chatrooms/5
        [ResponseType(typeof(Chatroom))]
        public IHttpActionResult GetChatroom(int id)
        {
            Chatroom chatroom = db.Chatroom.Find(id);
            if (chatroom == null)
            {
                return NotFound();
            }

            return Ok(chatroom);
        }

        // PUT: api/Chatrooms/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChatroom(int id, Chatroom chatroom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != chatroom.Id)
            {
                return BadRequest();
            }

            db.Entry(chatroom).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChatroomExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Chatrooms
        [ResponseType(typeof(Chatroom))]
        public IHttpActionResult PostChatroom(Chatroom chatroom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Chatroom.Add(chatroom);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ChatroomExists(chatroom.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = chatroom.Id }, chatroom);
        }

        // DELETE: api/Chatrooms/5
        [ResponseType(typeof(Chatroom))]
        public IHttpActionResult DeleteChatroom(int id)
        {
            Chatroom chatroom = db.Chatroom.Find(id);
            if (chatroom == null)
            {
                return NotFound();
            }

            db.Chatroom.Remove(chatroom);
            db.SaveChanges();

            return Ok(chatroom);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChatroomExists(int id)
        {
            return db.Chatroom.Count(e => e.Id == id) > 0;
        }
    }
}