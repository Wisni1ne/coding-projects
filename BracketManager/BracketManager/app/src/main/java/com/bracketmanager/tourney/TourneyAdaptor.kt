package com.bracketmanager.tourney

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.bracketmanager.R
import com.bracketmanager.models.TourneyModel
import kotlinx.android.synthetic.main.card_name.view.*

interface TourneyListener {
    fun onTourneyClick(tourney: TourneyModel)
}

class TourneyAdapter constructor(private var tourneys: List<TourneyModel>,
                              private val listener: TourneyListener)
    : RecyclerView.Adapter<TourneyAdapter.MainHolder>() {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MainHolder {
        return MainHolder(LayoutInflater.from(parent?.context).inflate(R.layout.card_name, parent, false))
    }

    override fun onBindViewHolder(holder: MainHolder, position: Int) {
        val tourney = tourneys[holder.adapterPosition]
        holder.bind(tourney, listener)
    }

    override fun getItemCount(): Int = tourneys.size

    class MainHolder constructor(itemView: View) : RecyclerView.ViewHolder(itemView) {

        fun bind(tourney: TourneyModel, listener: TourneyListener) {
            itemView.nameTitle.text = tourney.tourneyid
            itemView.setOnClickListener { listener.onTourneyClick(tourney) }
        }
    }

}