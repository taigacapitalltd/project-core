﻿using BeCoreApp.Data.EF.Extensions;
using BeCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeCoreApp.Data.EF.Configurations
{
    public class BlogCategoryConfiguration : DbEntityConfiguration<BlogCategory>
    {
        public override void Configure(EntityTypeBuilder<BlogCategory> entity)
        {
        }
    }
}
