using Godot;
using Godot.Collections;
using System;


/*
* Whole window size is 1280*720, position coord is (-640, -360)
* Tetris Scene size is 450*650,  position coord is (-225, -325)
*/

[GlobalClass]
public partial class globals : Node
{
	// Tetromino Type
	public enum Tetromino {
		I, L, Z, S  // S - Square
	}

	// Tetromino cells relative position coords
	public static class TetrominoCells
	{
		// (x, y)
		// positive direction: x-axis is to right, y-axis is to bottom
		public static Dictionary<Tetromino, Vector2[]> cells = new Dictionary<Tetromino, Vector2[]> {
			{Tetromino.I, new[] { new Vector2(0, 0), new Vector2(1, 0), new Vector2(2, 0), new Vector2(3, 0)}},
			{Tetromino.L, new[] { new Vector2(0, 1), new Vector2(0, 0), new Vector2(1, 0), new Vector2(2, 0)}},
			{Tetromino.Z, new[] { new Vector2(0, 1), new Vector2(1, 1), new Vector2(1, 0), new Vector2(2, 0)}},
			{Tetromino.S, new[] { new Vector2(0, 1), new Vector2(0, 0), new Vector2(1, 0), new Vector2(1, 1) }}
		};
	}

	// Tetromino Resources
	public static Dictionary<Tetromino, Resource> TetrominoResources = new Dictionary<Tetromino, Resource> {
			{Tetromino.I, GD.Load("res://resources/i_tetromino.tres")},
			{Tetromino.L, GD.Load("res://resources/l_tetromino.tres")},
			{Tetromino.Z, GD.Load("res://resources/z_tetromino.tres")},
			{Tetromino.S, GD.Load("res://resources/s_tetromino.tres")}
	};

	// rotation matrix
	public static Vector2[] clockwise_rotation_matrix = new Vector2[] { new Vector2(0, -1), new Vector2(1, 0) };
	public static Vector2[] counterclockwise_rotation_matrix = new Vector2[] { new Vector2(0, 1), new Vector2(-1, 0) };
}
