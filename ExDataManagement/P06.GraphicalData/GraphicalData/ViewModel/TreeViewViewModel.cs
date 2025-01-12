﻿//____________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/TP
//____________________________________________________________________________

using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TP.GraphicalData.ViewModel.MVVMLight;

namespace TP.GraphicalData.ViewModel
{
  /// <summary>
  /// Class MyViewModel - ViewModel implementation 
  /// </summary>
  /// <seealso cref="System.ComponentModel.INotifyPropertyChanged" />
  public class TreeViewViewModel : ViewModelBase
  {

    #region constructors
    public TreeViewViewModel()
    {
      ShowTreeViewCommand = new RelayCommand(AddRoot, () => ! string.IsNullOrEmpty(PathVariable));
      BrowseCommand = new RelayCommand(Browse);
    }
    #endregion

    #region View Model API
    public ObservableCollection<TreeViewModelItem> HierarchicalAreas { get; set; } = new ObservableCollection<TreeViewModelItem>();
    public string PathVariable
    {
      get => m_PathVariable;
      set
      {
        m_PathVariable = value;
        ShowTreeViewCommand.RaiseCanExecuteChanged();
        this.RaisePropertyChanged();
      }
    }
    private string m_PathVariable = string.Empty;
    public ICommand BrowseCommand { get; }
    public RelayCommand ShowTreeViewCommand { get; }
    #endregion

    #region private
    private Func<string> GetPath { set; get; } =  () => "Result of the FileOpenDialog";
    private void AddRoot()
    {
      TreeViewModelItem _rootItem = new RootTreeViewItem();
      HierarchicalAreas.Add(_rootItem);
    }
    private void Browse()
    {
      PathVariable = GetPath();
    }
    #endregion

  }
}
