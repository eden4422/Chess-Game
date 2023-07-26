// <copyright file="Queen.cs" company="Carlos Romero Sanchez">
// Copyright (c) Carlos Romero Sanchez. All rights reserved.
// </copyright>

namespace Chess_Engine.Pieces
{
    /// <summary>
    /// Inherets from ChessPiece class to create a queen.
    /// </summary>
    internal class Queen : ChessPiece
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Queen"/> class.
        /// </summary>
        public Queen()
        {
            this.Vanished = false;
            this.HorizontalMovement = 7;
            this.VerticalMovement = 7;
            this.FowardDiagonalMovement = 7;
            this.BackwardDiagonalMovement = 7;
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
