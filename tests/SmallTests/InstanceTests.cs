﻿using Vogen;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;

namespace SmallTests.InstanceTests;

[ValueObject(typeof(float))]
[Instance(name: "i1", value: 1.23f)]
[Instance(name: "i2", value: 2.34)]
[Instance(name: "i3", value: "3.45")]
[Instance(name: "i4", value: '2')]
public readonly partial struct MyFloatInstance
{
}

[ValueObject(typeof(decimal))]
[Instance(name: "i1", value: 1.23f)]
[Instance(name: "i2", value: 2.34)]
[Instance(name: "i3", value: "3.45")]
[Instance(name: "i4", value: '2')]
public readonly partial struct MyDecimalInstance
{
}

[ValueObject(typeof(double))]
[Instance(name: "i1", value: 1.23d)]
[Instance(name: "i2", value: 2.34)]
[Instance(name: "i3", value: "3.45")]
[Instance(name: "i4", value: '2')]
public readonly partial struct MyDoubleInstance
{
}

[ValueObject(typeof(char))]
[Instance(name: "i1", value: 1)]
[Instance(name: "i2", value: "2")]
[Instance(name: "i3", value: '3')]
[Instance(name: "i4", value: 4f)]
[Instance(name: "i5", value: 5d)]
public readonly partial struct MyCharInstance
{
}

[ValueObject(typeof(byte))]
[Instance(name: "i1", value: 1)]
[Instance(name: "i2", value: "2")]
[Instance(name: "i3", value: '3')]
[Instance(name: "i4", value: 4f)]
[Instance(name: "i5", value: 5d)]
public readonly partial struct MyByteInstance
{
}

public class InstanceTests
{
    [Fact]
    public void Basics()
    {
        using var _ = new AssertionScope();
        MyFloatInstance.i1.Value.Should().BeApproximately(1.23f, 0.01f);
        MyFloatInstance.i2.Value.Should().BeApproximately(2.34f, 0.01f);
        MyFloatInstance.i3.Value.Should().BeApproximately(3.45f, 0.01f);
        MyFloatInstance.i4.Value.Should().BeApproximately(2f, 0.01f);

        MyDecimalInstance.i1.Value.Should().Be(1.23m);
        MyDecimalInstance.i2.Value.Should().Be(2.34m);
        MyDecimalInstance.i3.Value.Should().Be(3.45m);
        MyDecimalInstance.i4.Value.Should().Be(2m);
        
        MyDoubleInstance.i1.Value.Should().BeApproximately(1.23f, 0.01f);
        MyDoubleInstance.i2.Value.Should().BeApproximately(2.34f, 0.01f);
        MyDoubleInstance.i3.Value.Should().BeApproximately(3.45f, 0.01f);
        MyDoubleInstance.i4.Value.Should().BeApproximately(2f, 0.01f);
        
        MyCharInstance.i1.Value.Should().Be('1');
        MyCharInstance.i2.Value.Should().Be('2');
        MyCharInstance.i3.Value.Should().Be('3');
        MyCharInstance.i4.Value.Should().Be('4');
        MyCharInstance.i5.Value.Should().Be('5');

        MyByteInstance.i1.Value.Should().Be(1);
        MyByteInstance.i2.Value.Should().Be(2);
        MyByteInstance.i3.Value.Should().Be(3);
        MyByteInstance.i4.Value.Should().Be(4);
        MyByteInstance.i5.Value.Should().Be(5);
        
    }
}