type somethingComplex = {
    foo: number,
    bar: string
}

function takeSomethingComplex(arg: somethingComplex){
    console.log(arg.foo, arg.bar);
}

function getBar(): string{
    return 'some bar';
}

const fail = {
    foo: 123,
    bar: getBar()
};

takeSomethingComplex(fail);