using FullTaskRepository.Interfaces;
using FullTaskRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullTaskRepository.Reposittory
{
   public class UnitOfWork<T>:IDisposable where T: class,IBaseEntity 
    {

        private ApplicationDbContext context = ApplicationDbContext.Create();
        private GenericRepository<T> PublicRepo_Prop;

        private GenericRepository<Test> departmentRepository;


        public GenericRepository<T> PublicRepo
        {
            get
            {

                if (this.PublicRepo_Prop == null)
                {
                    this.PublicRepo_Prop = new GenericRepository<T>(context);
                }
                return PublicRepo_Prop;
            }
        }

        #region AllRepositores
        public GenericRepository<Test> DepartmentRepository
        {
            get
            {

                if (this.departmentRepository == null)
                {
                    this.departmentRepository = new GenericRepository<Test>(context);
                }
                return departmentRepository;
            }
        }

        #endregion


        public void SaveChanges()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

