using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using AzureWebApi2FromScratch.Models;

namespace AzureWebApi2FromScratch.Controllers
{
    public class ContactsController : ApiController
    {
        // GET api/contacts        
        [SwaggerOperation("GetAll")]
        public IEnumerable<Contact> Get() {
            return new Contact[] { 
                new Contact {
                    ContactId = 1,
                    DisplayName = "José Ernesto Ocampo Cicero",
                    FirstName = "José Ernesto",
                    LastName = "Ocampo Cicero",
                    Email = "ernesto@sistrategia.com",
                    Phone = "(777) 328-8894"
                }
                ,new Contact {
                    ContactId = 2,
                    DisplayName = "Victor Manuel Ocampo Cicero",
                    FirstName = "Victor Manuel",
                    LastName = "Ocampo Cicero",
                    Email = "victor@sistrategia.com",
                    Phone = "(777) 328-8894"
                }
            };
        }

        // GET api/contacts/1
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IHttpActionResult Get(int id) {
            switch (id) {
                case 1: return Ok(new Contact {
                    ContactId = 1,
                    DisplayName = "José Ernesto Ocampo Cicero",
                    FirstName = "José Ernesto",
                    LastName = "Ocampo Cicero",
                    Email = "ernesto@sistrategia.com",
                    Phone = "(777) 328-8894"
                });
                case 2: return Ok(new Contact {
                    ContactId = 2,
                    DisplayName = "Victor Manuel Ocampo Cicero",
                    FirstName = "Victor Manuel",
                    LastName = "Ocampo Cicero",
                    Email = "victor@sistrategia.com",
                    Phone = "(777) 328-8894"
                });
                default: return NotFound();
            }
        }

        // POST api/contacts
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]Contact value) {
        }

        // PUT api/contacts/1
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]Contact value) {
        }

        // DELETE api/contacts/1
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id) {
        }
    }
}
