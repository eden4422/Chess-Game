// <copyright file="Pawn.cs" company="Carlos Romero Sanchez">
// Copyright (c) Carlos Romero Sanchez. All rights reserved.
// </copyright>

namespace Chess_Engine.Pieces
{
    /// <summary>
    /// Inherets from ChessPiece class to create a pawn.
    /// </summary>
    internal class Pawn : ChessPiece
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pawn"/> class.
        /// </summary>
        public Pawn()
        {
            this.Vanished = false;
            this.VerticalMovement = 2;
            this.HorizontalMovement = 0;
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
