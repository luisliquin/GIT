function takeSomethingComplex(arg) {
    console.log(arg.foo, arg.bar);
}
function getBar() {
    return 'some bar';
}
var fail = {
    foo: 123,
    bar: getBar()
};
takeSomethingComplex(fail);
