﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lenkovec
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LenkovetssEntities : DbContext
    {
        private static LenkovetssEntities _context;
        public LenkovetssEntities()
            : base("name=LenkovetssEntities")
        {
        }
        public static LenkovetssEntities GetContext()
        {
            if (_context == null)
            {
                _context = new LenkovetssEntities();
            }
            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Группа> Группа { get; set; }
        public virtual DbSet<Должность> Должность { get; set; }
        public virtual DbSet<Нагрузка> Нагрузка { get; set; }
        public virtual DbSet<Предмет> Предмет { get; set; }
        public virtual DbSet<Преподаватель> Преподаватель { get; set; }
        public virtual DbSet<УчёнаяСтепень> УчёнаяСтепень { get; set; }
        public virtual DbSet<ALLS> ALLS { get; set; }
    }
}