using Godot;
using Godot.Collections;
using System;


/*
* Whole window size is 1280*720, position coord is (-640, -360)
* Tetris Scene size is  450*650, position coord is (-225, -325)
* Tetris Instant size is  18*18, position coord is (-10, -350)
*/

[GlobalClass]
public partial class Globals : Node
{
	// TetrisType Type
	public enum TetrisType {
		I, L, Z, S  // S - Square
	}

	// TetrisType composition relative position coords
	public static class TetrisComposition
	{
		// (x, y)
		// positive direction: x-axis is to right, y-axis is to bottom
		public static Dictionary<TetrisType, Vector2[]> blocks = new Dictionary<TetrisType, Vector2[]> {
			{TetrisType.I, new[] { new Vector2(0, 0), new Vector2(1, 0), new Vector2(2, 0), new Vector2(3, 0)}},
			{TetrisType.L, new[] { new Vector2(0, 1), new Vector2(0, 0), new Vector2(1, 0), new Vector2(2, 0)}},
			{TetrisType.Z, new[] { new Vector2(0, 1), new Vector2(1, 1), new Vector2(1, 0), new Vector2(2, 0)}},
			{TetrisType.S, new[] { new Vector2(0, 1), new Vector2(0, 0), new Vector2(1, 0), new Vector2(1, 1) }}
		};
	}

	// TetrisType Resources
	public static Dictionary<TetrisType, TetrisProperty> tetris_resources = new Dictionary<TetrisType, TetrisProperty> {
			{TetrisType.I, GD.Load<TetrisProperty>("res://resources/i_tetris.tres")},
			{TetrisType.L, GD.Load<TetrisProperty>("res://resources/l_tetris.tres")},
			{TetrisType.Z, GD.Load<TetrisProperty>("res://resources/z_tetris.tres")},
			{TetrisType.S, GD.Load<TetrisProperty>("res://resources/s_tetris.tres")}
	};

	// rotation matrix
	public static Vector2[] clockwise_rotation_matrix = new Vector2[] { new Vector2(0, -1), new Vector2(1, 0) };
	public static Vector2[] counterclockwise_rotation_matrix = new Vector2[] { new Vector2(0, 1), new Vector2(-1, 0) };
}
