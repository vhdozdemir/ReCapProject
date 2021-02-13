using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate;
using Entities.DTOs;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalCarDetailDto> GetRentalCarDetailDto()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars on rental.CarId equals car.Id
                             join customer in context.Customers on rental.CustomerId equals customer.Id
                             join user in context.Users on customer.UserId equals user.Id
                             select new RentalCarDetailDto()
                             {
                                 CarId = car.Id,
                                 CarName = car.CarName,
                                 CustomerId = customer.Id,
                                 CustomerName = user.FirstName,
                                 CustomerSurname = user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
