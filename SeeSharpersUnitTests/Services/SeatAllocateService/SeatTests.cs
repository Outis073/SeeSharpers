using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpers.Services.SeatAllocateService;

namespace SeeSharpersUnitTest.Services.SeatAllocateService;

[TestClass]
public class SeatTests
{
    [TestMethod]
    public void Number_CanSetSeatNumber_NumberIsSet()
    {
        // Arrange
        Seat seat = new(new Vector2(10, 5));

        // Act
        seat.Number = 14;

        // Assert
        Assert.AreEqual(14, seat.Number);
    }

    [TestMethod]
    public void Number_NumberIsDefined_ReturnsInt()
    {
        // Arrange
        Seat seat = new(new Vector2(10, 5)) {Number = 12};

        // Act
        var result = seat.Number;

        // Assert
        Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void RowNumber_RowNumberIsDefined_ReturnsInt()
    {
        // Arrange
        Seat seat = new(new Vector2(10, 5));

        // Act
        var result = seat.RowNumber;

        // Assert
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void Position_VectorOfTheSeat_ReturnsVector2()
    {
        // Arrange
        Vector2 vector2 = new(10, 12);
        Seat seat = new(vector2);

        // Act
        var result = seat.Position;

        // Assert
        Assert.AreEqual(vector2, result);
    }

    [TestMethod]
    public void Occupied_SeatIsOccupied_ReturnsTrue()
    {
        // Arrange
        Seat seat = new(new Vector2(10, 12), true);

        // Act
        var result = seat.Occupied;

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Occupied_SeatIsNotOccupied_ReturnsFalse()
    {
        // Arrange
        Seat seat = new(new Vector2(10, 12));

        // Act
        var result = seat.Occupied;

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Equals_TwoSeatsAreEqual_ReturnsTrue()
    {
        // Arrange
        Seat seat = new(new Vector2(10, 5));
        Seat seat2 = new(new Vector2(10, 5));

        // Act
        var result = seat.Equals(seat2);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Equals_TwoSeatsAreNotEqual_ReturnsFalse()
    {
        // Arrange
        Seat seat = new(new Vector2(10, 5));
        Seat seat2 = new(new Vector2(11, 6));

        // Act
        var result = seat.Equals(seat2);

        // Assert
        Assert.IsFalse(result);
    }
}