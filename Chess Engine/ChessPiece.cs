// <copyright file="ChessPiece.cs" company="Carlos Romero Sanchez">
// Copyright (c) Carlos Romero Sanchez. All rights reserved.
// </copyright>

namespace Chess_Engine
{
    /// <summary>
    /// Class used to create all chess pieces.
    /// </summary>
    internal abstract class ChessPiece
    {
        /// <summary>
        /// Gets or sets a value indicating whether the piece has been captured.
        /// </summary>
        public bool Vanished { get; set; }

        /// <summary>
        /// Gets or sets the chess player color.
        /// </summary>
        public char Color { get; set; }

        /// <summary>
        /// Gets or sets horizonatal movement of the piece.
        /// </summary>
        public int HorizontalMovement { get; set; }

        /// <summary>
        /// Gets or sets vertical momevent of the piece.
        /// </summary>
        public int VerticalMovement { get; set; }

        /// <summary>
        /// Gets or sets the foward diagonal movement of the piece.
        /// </summary>
        public int FowardDiagonalMovement { get; set; }

        /// <summary>
        /// Gets or sets the backward diagonal movement of a piece.
        /// </summary>
        public int BackwardDiagonalMovement { get; set; }

        /// <summary>
        /// Abstract movement class for chess piece.
        /// </summary>
        public abstract void Movement();

        /// <summary>
        /// The capturing movement of each piece.
        /// </summary>
        public abstract void Capturing();
    }
}
