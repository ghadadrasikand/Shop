using Shop.Host.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Host.Inferastructure.IRepositories
{
    public interface ICategoryRepository
    {
        Category GetById(int Id);
        int Update(Category category);
        int Delete(Category category);

    }
}
