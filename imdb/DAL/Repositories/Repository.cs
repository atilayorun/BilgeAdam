﻿using imdb;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity:class
    {
        imdbContext db;

        public Repository()
        {
            db = new imdbContext();
        }

        public Repository(imdbContext db)
        {
            this.db = db;
        }

        public void Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
            db.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            db.Set<TEntity>().Remove(entity);
            db.SaveChanges();

        }

        public List<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public List<TEntity> GetEntities(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, TEntity>> expression2)
        {
            return db.Set<TEntity>().Where(expression).Select(expression2).ToList();
        }

        public TEntity GetByID(object id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(TEntity entityToUpdate)
        {
            db.Set<TEntity>().Attach(entityToUpdate);
            db.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public Boolean EntityExists(Expression<Func<TEntity,bool>> expression)
        {
            return db.Set<TEntity>().Any(expression);
        }
        public int GetIdByString(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, int>> expression2) {
            return db.Set<TEntity>().Where(expression).Select(expression2).FirstOrDefault();
        }

        public virtual TEntity GetById(TEntity id)
        {
            return db.Set<TEntity>().Find(id);
        }


        #region IRepository<T> Members


        #endregion
    }
}
