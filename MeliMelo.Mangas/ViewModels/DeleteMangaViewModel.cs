﻿using Caliburn.Micro;
using MeliMelo.Mangas.Models;

namespace MeliMelo.ViewModels
{
    public interface IDeleteMangaViewModelFactory
    {
        DeleteMangaViewModel Create(Manga manga);

        void Release(DeleteMangaViewModel view_model);
    }

    /// <summary>
    /// Represents the delete manga confirmation dialog
    /// </summary>
    public class DeleteMangaViewModel : Screen
    {
        /// <summary>
        /// Creates a new DeleteMangaViewModel
        /// </summary>
        /// <param name="manga"></param>
        public DeleteMangaViewModel(Manga manga)
        {
            DisplayName = "MeliMelo - Delete Manga";

            manga_ = manga;
        }

        /// <summary>
        /// Gets the delete message
        /// </summary>
        public string DeleteMessage
        {
            get
            {
                return "Are you really sure you want to delete manga \""
                    + manga_.Name
                    + "\" ? It will no longer be available"
                    + " and all chapter advancement will be lost.";
            }
        }

        /// <summary>
        /// Cancels the operation
        /// </summary>
        public void Cancel()
        {
            TryClose(false);
        }

        /// <summary>
        /// Confirms the operation
        /// </summary>
        public void Delete()
        {
            TryClose(true);
        }

        /// <summary>
        /// Manga to delete
        /// </summary>
        protected Manga manga_;
    }
}
