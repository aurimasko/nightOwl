﻿using System;
using System.Drawing;

namespace nightOwl.Views
{
    public interface IAddPersonView
    {
        void ShowMessage(string message);
        void Close();

        string NameSurname { get; set; }
        string BirthDate { get ; set;  }
        string MissingDate { get; set; }
        string AdditionalInfo { get; set; }
        string SelectedPersonName { get; set; }
        bool NameSurnameEnabled { get; set; }
        int SelectedPersonIndex { get; set;  }
        Image PersonImage { get; set; }
        bool PersonsListEnabled { get; set; }
        bool PersonsListTitle { get; set; }
        bool AddNewPersonBtnEnabled { get; set; }
        bool SelectPersonBtnEnabled { get; set; }
        bool UpdateInfoBtnEnabled { get; set; }
        bool CreateNewPersonDataBtnEnabled { get;  set; } 

        event EventHandler BackButtonClicked;
        event EventHandler CloseButtonClicked;
        event EventHandler CreateNewPersonDataButtonClicked;
        event EventHandler PersonSelectedFromList;
        event EventHandler NewPersonCreatingClicked;
        event EventHandler UpdatePersonCliked;
        event EventHandler SelectPersonButtonClicked;
    }
}