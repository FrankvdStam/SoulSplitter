﻿// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Windows.Input;

namespace SoulSplitter.UI.Generic;

public class RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute) : ICommand
{
    public RelayCommand(Action execute) : this((param) => execute(), (Func<object?, bool>?)null) { }
    public RelayCommand(Action execute, Func<bool> canExecute) : this((param) => execute(), (param) => canExecute()) { }
    public RelayCommand(Action execute, Func<object?, bool> canExecute) : this((param) => execute(), canExecute) { }
    public RelayCommand(Action<object?> execute) : this(execute, (Func<object?, bool>?)null) { }
    public RelayCommand(Action<object?> execute, Func<bool> canExecute) : this(execute, (param) => canExecute()) { }

    private readonly Action<object?> _execute = execute;
    private readonly Func<object?, bool>? _canExecute = canExecute;

    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }

    public bool CanExecute(object? parameter)
    {
        return _canExecute == null || _canExecute(parameter);
    }

    public void Execute(object? parameter)
    {
        _execute(parameter);
    }
}
