// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
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

namespace SoulMemory
{
    public interface ITimeable
    {
        /// <summary>
        /// Gets the current in game time in milliseconds.
        /// </summary>
        /// <returns></returns>
        int GetInGameTimeMilliseconds();

        /// <summary>
        /// Only returns true when the game is loaded and the timer should be running. False during load screens or on the main menu.
        /// </summary>
        /// <returns></returns>
        bool IsInGame();

        ///// <summary>
        ///// Returns true when the auto start conditions for a specific game are detected
        ///// </summary>
        ///// <returns></returns>
        //bool StartAutomatically();

        /// <summary>
        /// Returns true when initial load removal conditions have been met
        /// </summary>
        /// <returns></returns>
        bool InitialLoadRemoval();

        /// <summary>
        /// Reset IGT for initial load removal
        /// </summary>
        void ResetIgt();
    }
}
