﻿using System.Collections.Generic;
using System.Linq;
using Ui.Interfaces;
using Ui.Models;
using Ui.Services;

namespace Ui.ViewModelMappers
{
	public class DogOwnerViewModelMapper
	{
        private readonly IDogOwnerService _dogOwnerService;

        public DogOwnerViewModelMapper(IDogOwnerService dogOwnerService)
        {
            _dogOwnerService = dogOwnerService;
        }

        public DogOwnerListViewModel GetAllDogOwners()
		{
			var dogOwners = _dogOwnerService.GetAllDogOwners();
            return new DogOwnerListViewModel
			{
				DogOwnerViewModels = dogOwners.Select(e => new DogOwnerViewModel
				{
					OwnerName = e.OwnerName,
					DogNames = e.DogNames,
				}).ToList()
			};
		} 
	}
}