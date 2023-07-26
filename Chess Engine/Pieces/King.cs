// <copyright file="King.cs" company="Carlos Romero Sanchez">
// Copyright (c) Carlos Romero Sanchez. All rights reserved.
// </copyright>

namespace Chess_Engine.Pieces
{
    /// <summary>
    /// Inherets from ChessPiece class to create a king.
    /// </summary>
    internal class King : ChessPiece
    {
        public King()
        {
            this.Vanished = false;
            this.HorizontalMovement = 1;
            this.VerticalMovement = 1;
            this.FowardDiagonalMovement = 1;
            this.BackwardDiagonalMovement = 1;
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
