using System;

namespace reactgame.Test;

public class GameTests
{
	[Fact]
	public void CheckFusk_ShouldReturnTrue_whenKey() 
	{
		// Arrange
		Game game = new Game();
		char input = 'k'; // \n = char för ny rad 
		
		// Act
		bool result = game.CheckFusk(input);
		
		// Assert
		Assert.True(result);
	}
	
	[Fact]
	public void CheckFusk_ShouldReturnFalse_whenNoKey() 
	{
		// Arrange
		Game game = new Game();
		
		// Act
		bool result = game.CheckFusk('\0');
		
		// Assert
		Assert.False(result);
	}
	
	[Fact]
	public void FormatMilliseconds_test() 
	{
		// Arrange
		Game game = new Game();
		long millseconds = 80024;
		string expected = "1 minut, 20 sekunder och 24 hundradelar";
		
		// Act
		string actual = game.FormatMilliseconds(millseconds);
		
		// Assert
		Assert.Equal(expected, actual);
	}
}
