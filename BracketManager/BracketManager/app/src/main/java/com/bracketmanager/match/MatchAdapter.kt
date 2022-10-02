package com.bracketmanager.match

import com.bracketmanager.models.MatchModel
import kotlinx.android.synthetic.main.tourney_match.view.*
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.bracketmanager.R

interface MatchListener {
    fun onMatchClick(match: MatchModel)
}

class MatchAdapter constructor(private var matches: List<MatchModel>,
                               private val listener: MatchListener)
    : RecyclerView.Adapter<MatchAdapter.MainHolder>() {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MainHolder {
        return MainHolder(LayoutInflater.from(parent?.context).inflate(R.layout.tourney_main, parent, false))
    }

    override fun onBindViewHolder(holder: MainHolder, position: Int) {
        val match = matches[holder.adapterPosition]
        holder.bind(match, listener)
    }

    override fun getItemCount(): Int = matches.size

    class MainHolder constructor(itemView: View) : RecyclerView.ViewHolder(itemView) {

        fun bind(match: MatchModel, listener: MatchListener) {
            itemView.nameTopText.text = match.nameOne.userid
            itemView.nameBotText.text = match.nameTwo.userid
            itemView.scoreTop.setText(match.scoreOne.toString())
            itemView.scoreBot.setText(match.scoreTwo.toString())
            itemView.roundTitle.text = "Round " + match.round.toString()
            itemView.scoreTop.setEnabled(false)
            itemView.scoreBot.setEnabled(false)
            itemView.setOnClickListener { listener.onMatchClick(match) }
        }
    }

}