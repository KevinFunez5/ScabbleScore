using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordScrabble;
using System.Collections.Generic;
using System;

namespace WordScrabble.Tests
{
  [TestClass]
  public class ScrabbleWordTests
  {
    [TestMethod]
    public void ScrabbleScorer_CreateNewScrabbleWord_ScrabbleWord()
    {
      //Arrange
      string testWord = "friend";

      //Act
      ScrabbleWord friend = new ScrabbleWord(testWord);

      //Assert
      Assert.AreEqual(testWord, friend.Play);
    }

    [TestMethod]
    public void ToScore_CreateStringArray_StringArray()
    {
      //Arrange
      string testWord = "friend";
      char[] testBlob = {'f', 'r', 'i', 'e', 'n', 'd'};

      //Act
      ScrabbleWord friend = new ScrabbleWord(testWord);
      char[] scoreBlob = (friend.Play).ToCharArray();

      //Assert
      CollectionAssert.AreEqual(scoreBlob, testBlob);

    }
    
  }
}

