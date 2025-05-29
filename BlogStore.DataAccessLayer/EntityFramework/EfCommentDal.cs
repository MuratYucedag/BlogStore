using BlogStore.DataAccessLayer.Abstract;
using BlogStore.DataAccessLayer.Context;
using BlogStore.DataAccessLayer.Repositories;
using BlogStore.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        private readonly BlogContext _context;
        public EfCommentDal(BlogContext context) : base(context)
        {
            _context = context;
        }
    }
}