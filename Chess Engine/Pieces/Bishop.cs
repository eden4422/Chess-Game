﻿// <copyright file="Bishop.cs" company="Carlos Romero Sanchez">
// Copyright (c) Carlos Romero Sanchez. All rights reserved.
// </copyright>

namespace Chess_Engine.Pieces
{
    /// <summary>
    /// Inherets from ChessPiece class to create a bishop.
    /// </summary>
    internal class Bishop : ChessPiece
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bishop"/> class.
        /// </summary>
        public Bishop()
        {
            this.Vanished = false;
            this.BackwardDiagonalMovement = 7;
            this.FowardDiagonalMovement = 7;
        }

        public override void Capturing()
        {
            throw new System.NotImplementedException();
        }

        public override void Movement()
        {
            throw new System.NotImplementedException();
        }
    }
}
