//Background: Black Screen
Narrator: Dmitri is a 20-year-old, single parent of a toddler, Alexia. In his second year of university, Dmitri did very well in his first year, obtaining an “A” in all of his classes.  

Narrator: As a single parent, he is not able to start schoolwork until after his Alexia is fed, bathed, and put to bed, and after chores like dishes and laundry are completed. 
Narrator: He often works until midnight, and then needs to get up at 6 a.m. to get Alexia ready, catch the bus, take Alexia to the daycare, and then walk to the university. Dmitri is not getting enough sleep.  

Narrator: By October, however, things have suddenly changed and he has boundless energy. This is the complete opposite to the depressions he’s had—then, he couldn’t get out of bed. Now, he doesn’t need sleep!

Narrator: He is able to work until 5 am, and then get up at 6 am and get out the door with Alexia. 
Narrator: Even though he gets to the university on time, he seldom attends class because realizes he is much smarter than all the other students and no longer needs to attend class, other than to hand in assignments and for the midterm and final exams.  

Narrator: Instead, he hangs out playing pool, walking along the riverbank trails for hours, and going to the campus bar. 
Narrator: Always shy, he’s now boisterous, always laughing loudly, and having a million conversations, talking a mile a minute.  

Narrator: Sometimes people don’t seem to understand what he’s talking about, but again, he knows he’s smarter than them and he’s the funniest person in the room--they just don’t get it. 

//Background: Dr. Higashi's Office Interior

Narrator: Sitting at my desk in my office, I suddenly hear my door swing open. It is Dmitri, a student I had reached out to meet with. 

Narrator: He hadn’t confirmed he would attend, so I am a bit surprised to see him here. He barged in fifteen minutes late without knocking, but I decide to greet him with a smile nonetheless. 

Dr. Higashi: Ah, glad you could make it, Dmitri. Have a seat.

Dmitri: Naw, I’m good.

Narrator: Dmitri continues to stand there, shifting his body weight back and forth and fidgeting. An awkward pause follows. 

Dr. Higashi: I want to talk to you about the course. Your grades have been dropping and you have been missing nearly every class.

Narrator: Dmitri rolls his eyes. He seems to be acting a bit differently than usual.  

Narrator: On one hand, his behavior strikes me as disrespectful, but I would also like to find out why he is suddenly struggling in class. 
    + [I'm irritated with Dmitri's behaviour...]
        -> irritated()
    + [I'm curious why Dmitri is struggling in class...]
        -> curious()
        

=== irritated ===
Dr. Higashi: I want to talk to you about the course. You haven’t been in class and the paper you handed in was nonsense.

Dr. Higashi: You would have seen your grade if you’d bothered to come to class, and collect your paper. 

Narrator: With an offended look on his face, Dmitri stepped closer to my desk. 

Dmitri: NONESENSE?!

Dmitri: Do you not recognize brilliance when you see it? No, probably not. Simple people can’t see genius.

The nerve! Taken aback, I fire back. 

Dr. Higashi: Like I said, you seemed like a good student at the beginning of term. Now you’re failing, and your behaviour here is unacceptable.

Dr. Higashi: I won’t tolerate this. 

Narrator: Dmitri pauses for a split second before making a smirk. 

Dmitri: Hehe!!! HAHAHAHA!

Narrator: His stifled laughter turned into a riotous roar. He was laughing and laughing, doubled over
    + [I'm angry about Dmitri's actions...]
        -> angrier()
    + [I'm confused by Dmitri's actions...]
        -> confused()
        
        
=== angrier ===
Dr. Higashi: I don’t know what is wrong with you, but you are out of control and I don’t need you in my class.

Dr. Higashi: I don’t know if you’re drinking or on drugs, but get out, and don’t come back to class.

Dr. Higashi: We’re done. You’ll be getting an ‘incomplete’ grade in this course.

Narrator: Dmitri kicks the garbage can across the room in a fit of rage before leaving the office yelling obscenities down the hall. 

Narrator: Having had enough of his behavior, I decide to call campus security to escort him out. 

Narrator: The cause of this sudden outburst is puzzling, but I have no patience for this kind of behavior. 
    -> daycare_bad()

=== curious ===
Dr. Higashi: I wanted to talk to you about the course. For the first few weeks of the term, you attended regularly, and were doing really good work.

Dr. Higashi: I’ve noticed your absence and that your academic work is failing. I’m wondering if there is something happening in your life, and if you are doing ok?

Dmitri: I’m great! The problem is with you and your useless class!

Dmitri: I’m too smart for it and have better things to do with my time. See you at convocation!

Narrator: Dmitri pauses for a split second before making a smirk. 

Dmitri: Hehe!!! HAHAHAHA! 

Narrator: His stifled laughter turned into a riotous roar. He was laughing and laughing, doubled over. 
    + [I'm confused by Dmitri's actions...]
        -> confused()
    + [I think something is wrong with Dmitri...]
        -> somethings_wrong()

=== confused ===

Narrator: I am shocked by his behavior. Though I am concerned for Dmitri, I have no idea how to handle this. 

Dr. Higashi: What is going in with you? Have you been drinking? Are you on drugs? Whatever it is, you need help. 

Dr. Higashi: Because of your strong start in the course, I’m going to give you the benefit of the doubt. 
Dr. Higashi: I’m feeling generous and I’ll give you a week to come to your senses, apologize, change your behaviour and attitude, start attending class, and actually put in some effort. 

Dr. Higashi: You’re not rewriting this paper, though-- the grade stays. 

Narrator: Dmitri pauses again and straightens up, staring directly at me. Then he bursts into tears.

Narrator: He falls to the floor, crying.
    + [I'm scared by Dmitri's actions...]
        -> scared()
    + [I think something is very wrong with Dmitri...]
        -> somethings_wrong()

=== scared ===
Dr. Higashi: I am going to have to ask you to leave my office. You’re freaking me out. 

Narrator: With a scowl, Dmitri stormed out of the room. I can hear him walking down the hall, yelling that he’s being persecuted for his brilliance. 

Narrator: The confrontation left me baffled and confused. What had happened to Dmitri?
    -> daycare_bad()

=== daycare_bad ===
// Background: Daycare front desk
    
Narrator: After being escorted out, Dmitri went to the daycare to pick up his daughter. However, the daycare staff were alarmed by his behavior and refused to allow him to take Alexia. 

Narrator: Dmitri suddenly bursts into tears. 

Dmitri: But she is my daughter! How can you refuse to let me take her!? 

Narrator: Concerned for Alexia’s safety, the daycare staff felt that the best option was to call child protective services. 

Narrator: Alexia was taken to a child crisis centre and the police were called to pick up Dmitri.  

Narrator: In the police car, he went back and forth from yelling angrily that he was being kidnapped, crying and laughing. 
Narrator: Thankfully, the police recognized Dmitri’s mental distress and opted to take him to the hospital.  

// Background Black Screen

Narrator: At the hospital, Dmitri was diagnosed with Bipolar Disorder and was admitted to a psychiatric ward because while in this state, he may be reckless with his personal well-being, and is at risk of suicide. 
Narrator: He was to remain in the hospital for 2 weeks, until the medication he takes can level his mood. 

Narrator: Eventually, Dmitri got his daughter back into his custody, but was ultimately suspended from classes. 
Narrator: He was unable to return to classes that semester and because of his mental state, didn’t formally withdraw from his classes and so never managed to get any of his tuition back. 
    -> END
    
=== somethings_wrong ===
Narrator: Realizing the severity of the situation, I decide it’s best to remain calm and try and help Dmitri. 

Dr. Higashi: Listen, Dmitri. I know that you’re a very smart student. You can still finish the course with a really good mark. 

Dr. Higashi: The two of us just need to work together to find the best way for you to complete the course.

Dmitri: As if I need your help! How do you even still have a job?! 

Dmitri’s speech started to become faster and louder. He was becoming harder to understand. 

Narrator: I consider for a moment calling campus security, but realize that Dmitri needs help, not just to be dragged off campus. 

Dr. Higashi: I think I know someone who can help. I’ll give them a call. 

Narrator: I pick up my phone and start dialing the number of a mobile crisis unit.  

Narrator: While waiting for them to arrive, I decide to stay with Dmitri as he rants and laughs and cries.  

Narrator: I figure by remaining calm and agreeing with the nonsensical words Dmitri is rapidly speaking, I may be able to avoid further escalating the situation.  

Narrator: In his current state, he needs help that I alone simply cannot provide. 

//Background: Black Screen

Narrator: The mobile crises unit soon arrived and took over the situation, including calling an ambulance.   

Narrator: After a lengthy assessment at the hospital, Dmitri was diagnosed with Bipolar I Disorder and admitted to a psychiatric ward because while in this state, he may be reckless with his personal well-being, and is at risk of suicide. 
Narrator: He was to remain in the hospital for 2 weeks, until the medication he takes can level his mood. 

Narrator: Eventually, Dmitri got his daughter back into his custody. 

Narrator: Once he was again stable, he brought medical documentation to the Student Accessibility Centre and sent letters to all his professors notifying them of his diagnosis.  

Narrator: The accessibility office gave him a choice: take a medical withdrawal on his transcript or defer the remaining course work and final exam. 

Narrator: Dmitri will be on his medications for the rest of his life.  

Narrator: When he returns to school the next term, the medications make him very groggy, making attending classes and finishing assignments very difficult. 
Narrator: He is advised to take a lighter course load. Because of this, it will take him six years to complete his bachelor’s degree, but he eventually does graduate. 

Narrator: He and Alexia are doing well. 
    -> END