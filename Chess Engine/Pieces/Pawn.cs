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
        public Pawn()
        {
            this.Vanished = false;
            this.VerticalMovement = 2;
            this.HorizontalMovement = 0;
        }

        public override void Movement()
        {

        }

        public override void Capturing()
        {
            
        }
    }
}
