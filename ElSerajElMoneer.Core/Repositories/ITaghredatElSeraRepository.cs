﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElSerajElMoneer.Data.Dtos;
using ElSerajElMoneer.Server.Dtos;
using ElSerajElMoneer.Server.Extension;
using ElSerajElMoneer.Data.Models;

namespace ElSerajElMoneer.Core.Repositories
{
    public interface ITaghredatElSeraRepository
    {
        Task<IEnumerable<TaghredatElSera>> GetAllAsync();
        Task<(MetaData, IEnumerable<TaghredatElSera>)> GetAllPagedAsync(TaghredatParametersDto taghredatParametersDto);
        Task<TaghredatElSera> GetById(string id);
        Task<TaghredatElSera> CreateTaghredaAsync(TaghredatElSera taghreda);
        Task UpdateTaghredaAsync(string id, TaghredatElSera updatedTaghreda);
        Task UpdateNumberOfDownloadsByIdAsync(string id);
        Task UpdateNumberOfWatchesByIdAsync(string id);
        Task DeleteTaghredaAsync(TaghredatElSera taghreda);
    }
}
