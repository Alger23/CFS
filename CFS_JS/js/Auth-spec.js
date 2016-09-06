describe('CFS', function() {
  it('should encode', function() {
    var result = CFS('1234');
    expect(result).toEqual('4D48FCD27827B82C5E831B9896C57C');
  });
});