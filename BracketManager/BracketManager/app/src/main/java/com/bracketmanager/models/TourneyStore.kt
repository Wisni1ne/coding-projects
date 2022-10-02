package com.bracketmanager.models

interface TourneyStore {
    fun findAll(): List<TourneyModel>
    fun create(tourney: TourneyModel)
    fun update(tourney: TourneyModel)
    fun delete(tourney: TourneyModel)
}