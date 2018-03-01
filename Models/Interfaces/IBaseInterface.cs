using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public interface IBaseInterface<T>
    {
        DataResult Insert(T viewModel);
        DataResult Update(T viewModel);
        DataResult Delete(T viewModel);

        DataResult GetAll();
        DataResult GetById(int id);

    }
}
