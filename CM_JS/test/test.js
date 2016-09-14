var assert = require('assert');
describe('Extension Method- startsWith tests', function() {
   describe('startsWith- hang', function() {
    it('should return true when the string matches', function() {
      assert.equal( true, "hang the dj".startsWith("hang"));
    });
  });
  describe('startsWith- I’ve got a room for rent', function() {
    it('should return false when the string does not match', function() {
      assert.equal( false, "hang the dj".startsWith("I’ve got a room for rent"));
    });
  });
  	describe('startsWith- ""', function() {
    it('should return true when the string matches', function() {
      assert.equal( true, "hang the dj".startsWith(""));
    });
  });
    describe('startsWith- hang the', function() {
    it('should return true when the string matches', function() {
      assert.equal( true, "hang the dj".startsWith("hang the"));
    });
  });
    describe('startsWith- han', function() {
    it('should return true when the string matches', function() {
      assert.equal( true, "hang the dj".startsWith("han"));
    });
  });
    describe('startsWith- hang t', function() {
    it('should return true when the string matches', function() {
      assert.equal( true, "hang the dj".startsWith("hang t"));
    });
  });
    describe('startsWith- 42', function() {
    it('should return false when the string does not match', function() {
      assert.equal( false, "hang the dj".startsWith(42));
    });
  });
    describe('startsWith- { first: “Johnny” }', function() {
    it('should return false when the string does not match', function() {
      assert.equal( false, "hang the dj!".startsWith("{ first: “Johnny” }"));
    });
  });
});





describe('Extension Method- endsWith tests', function() {
  describe('endsWith- dj', function() {
    it('should return true when the string matches', function() {
      assert.equal( true, "hang the dj".endsWith("dj"));
    });
  });
  describe('endsWith- Panic on the streets', function() {
    it('should return false when the string does not match', function() {
      assert.equal( false, "hang the dj".endsWith("Panic on the streets"));
    });
  });
  	describe('endsWith- ""', function() {
    it('should return true when the string matches', function() {
      assert.equal( true, "hang the dj".endsWith(""));
    });
  });
    describe('endsWith- the dj', function() {
    it('should return true when the string matches', function() {
      assert.equal( true, "hang the dj".endsWith("the dj"));
    });
  });
    describe('endsWith- e dj', function() {
    it('should return true when the string matches', function() {
      assert.equal( true, "hang the dj".endsWith("e dj"));
    });
  });
    describe('endsWith- j', function() {
    it('should return true when the string matches', function() {
      assert.equal( true, "hang the dj".endsWith("j"));
    });
  });
    describe('endsWith- 42', function() {
    it('should return false when the string does not match', function() {
      assert.equal( false, "hang the dj".endsWith(42));
    });
  });
    describe('endsWith- { first: “Johnny” }', function() {
    it('should return false when the string does not match', function() {
      assert.equal( false, "hang the dj!".endsWith("{ first: “Johnny” }"));
    });
  });
});

