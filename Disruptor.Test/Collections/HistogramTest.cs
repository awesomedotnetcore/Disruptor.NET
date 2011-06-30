﻿using System;
using NUnit.Framework;
using Disruptor;
using Disruptor.Collections;

namespace Disruptor.Test.Collections
{
	[TestFixture]
	public class HistogramTest
	{
	    public static readonly long[] Intervals = new long[]{ 1, 10, 100, 1000, long.MaxValue };
	    private Histogram histogram = new Histogram(Intervals);
	
	    [Test]
	    public void ShouldSizeBasedOnBucketConfiguration()
	    {
	    	Assert.AreEqual(Intervals.Length, histogram.Size);
	    }
	/*
	    [Test]
	    public void shouldWalkIntervals()
	    {
	        for (int i = 0, size = histogram.getSize(); i < size; i++)
	        {
	            assertThat(Long.valueOf(histogram.getUpperBoundAt(i)), is(Long.valueOf(INTERVALS[i])));
	        }
	    }
	
	    [Test]
	    public void shouldConfirmIntervalsAreInitialised()
	    {
	        for (int i = 0, size = histogram.getSize(); i < size; i++)
	        {
	            assertThat(Long.valueOf(histogram.getCountAt(i)), is(Long.valueOf(0L)));
	        }
	    }
	
	    [Test](expected = IllegalArgumentException.class)
	    public void shouldThrowExceptionWhenIntervalLessThanOrEqualToZero()
	    {
	        new Histogram(new long[]{-1, 10, 20});
	    }
	
	    [Test](expected = IllegalArgumentException.class)
	    public void shouldThrowExceptionWhenIntervalDoNotIncrease()
	    {
	        new Histogram(new long[]{1, 10, 10, 20});
	    }
	
	    [Test]
	    public void shouldAddObservation()
	    {
	        assertTrue(histogram.addObservation(10L));
	        assertThat(Long.valueOf(histogram.getCountAt(1)), is(Long.valueOf(1L)));
	    }
	
	    [Test]
	    public void shouldNotAddObservation()
	    {
	        Histogram histogram = new Histogram(new long[]{ 10, 20, 30 });
	        assertFalse(histogram.addObservation(31));
	    }
	
	    [Test]
	    public void shouldAddObservations()
	    {
	        addObservations(histogram, 10L, 30L, 50L);
	
	        Histogram histogram2 = new Histogram(INTERVALS);
	        addObservations(histogram2, 10L, 20L, 25L);
	
	        histogram.addObservations(histogram2);
	
	        assertThat(Long.valueOf(6L), is(Long.valueOf(histogram.getCount())));
	    }
	
	    [Test](expected = IllegalArgumentException.class)
	    public void shouldThrowExceptionWhenIntervalsDoNotMatch()
	    {
	        Histogram histogram2 = new Histogram(new long[]{ 1L, 2L, 3L});
	        histogram.addObservations(histogram2);
	    }
	
	    [Test]
	    public void shouldClearCounts()
	    {
	        addObservations(histogram, 1L, 7L, 10L, 3000L);
	        histogram.clear();
	
	        for (int i = 0, size = histogram.getSize(); i < size; i++)
	        {
	            assertThat(Long.valueOf(histogram.getCountAt(i)), is(Long.valueOf(0)));
	        }
	    }
	
	    [Test]
	    public void shouldCountTotalObservations()
	    {
	        addObservations(histogram, 1L, 7L, 10L, 3000L);
	
	        assertThat(Long.valueOf(histogram.getCount()), is(Long.valueOf(4L)));
	    }
	
	    [Test]
	    public void shouldGetMeanObservation()
	    {
	        final long[] INTERVALS = new long[]{ 1, 10, 100, 1000, 10000 };
	        final Histogram histogram = new Histogram(INTERVALS);
	
	        addObservations(histogram, 1L, 7L, 10L, 10L, 11L, 144L);
	
	        assertThat(histogram.getMean(), is(new BigDecimal("32.67")));
	    }
	
	    [Test]
	    public void shouldCorrectMeanForSkewInTopAndBottomPopulatedIntervals()
	    {
	        final long[] INTERVALS = new long[]{ 100, 110, 120, 130, 140, 150, 1000, 10000 };
	        final Histogram histogram = new Histogram(INTERVALS);
	
	        for (long i = 100; i < 152; i++)
	        {
	            histogram.addObservation(i);
	        }
	
	        assertThat(histogram.getMean(), is(new BigDecimal("125.02")));
	    }
	
	    [Test]
	    public void shouldGetMaxObservation()
	    {
	        addObservations(histogram, 1L, 7L, 10L, 10L, 11L, 144L);
	
	        assertThat(Long.valueOf(histogram.getMax()), is(Long.valueOf(144L)));
	    }
	
	    [Test]
	    public void shouldGetMinObservation()
	    {
	        addObservations(histogram, 1L, 7L, 10L, 10L, 11L, 144L);
	
	        assertThat(Long.valueOf(histogram.getMin()), is(Long.valueOf(1L)));
	    }
	
	    [Test]
	    public void shouldGetTwoNinesUpperBound()
	    {
	        final long[] INTERVALS = new long[]{ 1, 10, 100, 1000, 10000 };
	        final Histogram histogram = new Histogram(INTERVALS);
	
	        for (long i = 1; i < 101; i++)
	        {
	            histogram.addObservation(i);
	        }
	
	        assertThat(Long.valueOf(histogram.getTwoNinesUpperBound()), is(Long.valueOf(100L)));
	    }
	
	    [Test]
	    public void shouldGetFourNinesUpperBound()
	    {
	        final long[] INTERVALS = new long[]{ 1, 10, 100, 1000, 10000 };
	        final Histogram histogram = new Histogram(INTERVALS);
	
	        for (long i = 1; i < 102; i++)
	        {
	            histogram.addObservation(i);
	        }
	
	        assertThat(Long.valueOf(histogram.getFourNinesUpperBound()), is(Long.valueOf(1000L)));
	    }
	
	    [Test]
	    public void shouldToString()
	    {
	        addObservations(histogram, 1L, 7L, 10L, 300L);
	
	        String expectedResults = "Histogram{min=1, max=300, mean=53.25, 99%=1000, 99.99%=1000, [1=1, 10=2, 100=0, 1000=1, 9223372036854775807=0]}";
	        assertThat(histogram.toString(), is(expectedResults));
	    } */
	
		private void AddObservations(Histogram histogram, params long[] observations)
	    {
	        for (int i = 0, size = observations.Length; i < size; i++)
	        {
	            histogram.AddObservation(observations[i]);
	        }
	    }
	}
}
