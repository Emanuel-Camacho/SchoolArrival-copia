using Application.Models.Dtos;
using Application.Models.Requests;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class AdminMapping
    
    {               //recibe objeto y lo convierte y devuelve en usuario
        public User FromRequestToEntity(AdminRequest dto) //FromRequestToEntity es un metodo de la clase adminmappin
        {                                                 //recib eobjeto caragdo a mano por usuario 
            
            var user = new User                        //Crea var usuario con tipo de dato usuario: seria la clase usuario con todas su propiedades
            {                                            //id no esta porque lo autogenera
                Email = dto.Email,
                FullName = dto.FullName,
                Password = dto.Password,
                PhoneNumber = dto.PhoneNumber,
                DNI = dto.DNI,
                IsActive = true,
                Role = Role.Admin,
            };

            return user;
        }

        public AdminDto FromEntityToResponse(User dto)
        {
            var request = new AdminDto
            {
                Id = dto.Id,
                FullName = dto.FullName,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                DNI = dto.DNI,
                Role = dto.Role.ToString(),
            };
            return request;
        }

        public User FromEntityToEntityUpdated(User user, AdminRequest userRequest)
        {
            user.FullName = userRequest.FullName ?? user.FullName;
            user.Email = userRequest.Email ?? user.Email;
            user.PhoneNumber = userRequest.PhoneNumber ?? user.PhoneNumber;            
            return user;
        }
    }
}
