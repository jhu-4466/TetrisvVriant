using Godot;
using System;

public partial class Block : Area2D
{
	// @onready
	private Sprite2D sprite_2d;
	private CollisionShape2D collision_shape_2d;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// preload
		sprite_2d = GetNode<Sprite2D>("Sprite2D");
		collision_shape_2d = GetNode<CollisionShape2D>("CollisionShape2D");
	}

	public void set_texture(Texture2D texture){
		sprite_2d.Texture = texture;
	}

	public Vector2 get_size(){
		return collision_shape_2d.Shape.GetRect().Size;
	}

	// // Called every frame. 'delta' is the elapsed time since the previous frame.
	// public override void _Process(double delta)
	// {
	// }
}
