﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IimageFileService
    {
        IimageFileDAL _iimageFileDAL;

        public ImageFileManager(IimageFileDAL iimageFileDAL)
        {
            _iimageFileDAL = iimageFileDAL;
        }

        public List<ImageFile> GetList()
        {
           return _iimageFileDAL.List();
        }
    }
}
