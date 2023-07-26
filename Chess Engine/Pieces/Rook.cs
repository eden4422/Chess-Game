// <copyright file="Rook.cs" company="Carlos Romero Sanchez">
// Copyright (c) Carlos Romero Sanchez. All rights reserved.
// </copyright>

namespace Chess_Engine.Pieces
{
    /// <summary>
    /// Inherets from ChessPiece class to create a rook.
    /// </summary>
    internal class Rook : ChessPiece
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rook"/> class.
        /// </summary>
        public Rook()
        {
            this.Vanished = false;
            this.VerticalMovement = 7;
            this.HorizontalMovement = 7;
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
