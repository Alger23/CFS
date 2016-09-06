describe('MD5', function() {
  it('should hash to MD5', function() {
    var v='4D48FCD27827B82C5E831B9896C57C'+'1234';
    var result = MD5(v);
    expect(result).toEqual("e1a2eb2efddd07f561594f8337e88645");
  });
});